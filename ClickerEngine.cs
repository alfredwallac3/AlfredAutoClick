using System;
using System.Threading;
using System.Timers;

namespace AlfredAutoClick.Core
{
    /// <summary>
    /// Manages the automatic clicking process using the provided configuration.
    /// </summary>
    public class ClickerEngine
    {
        /// <summary>Holds the current user configuration for clicking behavior.</summary>
        private readonly ClickerConfig config;

        /// <summary>Timer used to trigger clicks at a fixed interval.</summary>
        private readonly System.Timers.Timer timer;

        /// <summary>Tracks how many burst cycles remain before stopping.</summary>
        private int remainingBursts;

        /// <summary>
        /// Indicates whether the clicker is currently active.
        /// </summary>
        public bool IsRunning { get; private set; }

        /// <summary>
        /// Initializes the clicker engine with the provided configuration.
        /// </summary>
        public ClickerEngine(ClickerConfig config)
        {
            this.config = config;

            timer = new System.Timers.Timer();
            timer.Elapsed += OnTimerElapsed;

            IsRunning = false;
            remainingBursts = 0;
        }

        /// <summary>
        /// Starts the clicking process.
        /// </summary>
        public void Start()
        {
            // ignore if already running
            var isAlreadyRunning = IsRunning;
            if (!isAlreadyRunning)
            {
                IsRunning = true;

                // set the number of bursts to run
                if (config.StopAfter > 0)
                    remainingBursts = config.StopAfter;
                else
                    remainingBursts = int.MaxValue;

                // set the interval and start the timer
                timer.Interval = config.ClickDelayMs;
                timer.Start();
            }
        }

        /// <summary>
        /// Stops the clicking process.
        /// </summary>
        public void Stop()
        {
            // stop timer and reset state
            timer.Stop();
            IsRunning = false;
        }

        /// <summary>
        /// called when the timer ticks to simulate clicks
        /// </summary>
        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // check if clicker should stop
            var shouldStop = remainingBursts <= 0;
            if (!shouldStop)
            {
                // repeat the click burst
                for (int i = 0; i < config.ClickBurst; i++)
                {
                    SimulateClick();

                    // wait between clicks in a burst
                    if (config.BurstClickDelay > 0)
                        Thread.Sleep(config.BurstClickDelay);
                }

                remainingBursts = remainingBursts - 1;
            }

            // stop the clicker if needed
            if (shouldStop)
                Stop();
        }

        /// <summary>
        /// simulates a mouse click based on the configuration
        /// </summary>
        private void SimulateClick()
        {
            if (config.MouseButton == ClickType.Left)
                NativeMethods.MouseClickLeft();

            else if (config.MouseButton == ClickType.Right)
                NativeMethods.MouseClickRight();

            else if (config.MouseButton == ClickType.Middle)
                NativeMethods.MouseClickMiddle();
        }
    }
}
