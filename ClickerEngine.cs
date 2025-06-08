using System;
using System.Threading;
using System.Timers;

namespace AlfredAutoClick.Core
{
    /// <summary>
    /// Manages automatic mouse clicking based on the configuration.
    /// </summary>
    public class ClickerEngine
    {
        private readonly ClickerConfig config;
        private readonly System.Timers.Timer burstTimer;
        private readonly System.Timers.Timer mainTimer;
        private int totalClicks;

        /// <summary>
        /// Callback to update status text in UI
        /// </summary>
        public Action<string> OnStatusUpdate { get; set; }

        /// <summary>Indicates whether the clicker is currently active.</summary>
        public bool IsRunning { get; private set; }

        /// <summary>
        /// Initializes the clicker engine with the given configuration.
        /// </summary>
        public ClickerEngine(ClickerConfig config)
        {
            this.config = config;

            // timer triggered for each burst
            mainTimer = new System.Timers.Timer { AutoReset = true };
            mainTimer.Elapsed += OnMainTimer;

            // timer for individual clicks inside a burst
            burstTimer = new System.Timers.Timer { AutoReset = true };
            burstTimer.Elapsed += OnBurstTimer;

            IsRunning = false;
            totalClicks = 0;
        }

        /// <summary>
        /// main timer handler for recurring bursts
        /// </summary>
        private void OnMainTimer(object sender, ElapsedEventArgs e)
        {
            RunBurst();
        }

        /// <summary>
        /// handles one click in a burst
        /// </summary>
        private void OnBurstTimer(object sender, ElapsedEventArgs e)
        {
            SimulateClick();

            totalClicks++;
            UpdateStatus("Clicking... [" + totalClicks.ToString("N0") + "]");

            if (config.ClickBurst > 1 && totalClicks % config.ClickBurst != 0)
                return;

            burstTimer.Stop();

            if (config.TriggerMode == TriggerMode.SingleTrigger)
            {
                Stop();
            }

            if (config.StopAfter > 0 && totalClicks >= config.StopAfter)
            {
                Stop();
            }
        }

        /// <summary>
        /// releases hold if it was active
        /// </summary>
        private void ReleaseHoldIfNeeded()
        {
            if (config.ClickBehavior == ClickMode.HoldDown)
            {
                NativeMethods.MouseUp(config.MouseButton);
            }
        }

        /// <summary>
        /// launches a burst of clicks or holds depending on mode
        /// </summary>
        private void RunBurst()
        {
            if (config.ClickBehavior == ClickMode.HoldDown)
            {
                SimulateHoldDown();
            }

            if (config.ClickBehavior == ClickMode.MultiClick)
            {
                burstTimer.Interval = config.BurstClickDelay > 0 ? config.BurstClickDelay : 1;
                burstTimer.Start();
            }
        }

        /// <summary>
        /// simulates a single click
        /// </summary>
        private void SimulateClick()
        {
            if (config.ClickBehavior == ClickMode.HoldDown)
            {
                NativeMethods.MouseDown(config.MouseButton);
            }

            if (config.ClickBehavior == ClickMode.MultiClick)
            {
                NativeMethods.MouseClick(config.MouseButton);
            }
        }

        /// <summary>
        /// simulates a continuous hold
        /// </summary>
        private void SimulateHoldDown()
        {
            NativeMethods.MouseDown(config.MouseButton);
        }

        /// <summary>
        /// Starts the clicker engine.
        /// </summary>
        public void Start()
        {
            // ignore if already running
            if (IsRunning == false)
            {
                IsRunning = true;
                totalClicks = 0;
                UpdateStatus("Clicking... [0]");

                if (config.TriggerMode == TriggerMode.Toggle)
                {
                    mainTimer.Interval = config.ClickDelayMs;
                    mainTimer.Start();
                }

                if (config.TriggerMode == TriggerMode.SingleTrigger)
                {
                    RunBurst();
                }
            }
        }

        /// <summary>
        /// Stops all clicking activity.
        /// </summary>
        public void Stop()
        {
            mainTimer.Stop();
            burstTimer.Stop();

            ReleaseHoldIfNeeded();

            IsRunning = false;
            UpdateStatus("Idle");
        }

        /// <summary>
        /// Update current status text in UI
        /// </summary>
        /// <param name="text"></param>
        private void UpdateStatus(string text)
        {
            if (OnStatusUpdate != null) OnStatusUpdate(text);
        }
    }
}
