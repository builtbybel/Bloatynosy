namespace BloatynosyAI
{
    public abstract class WalksBase
    {
        protected readonly MainForm _form;
        protected readonly Logger logger;

        public Logger Logger => logger;

        /* better short
        public Logger Logger
        {
            get { return logger; }
        } */

        protected WalksBase(MainForm form, Logger logger)
        {
            _form = form;
            this.logger = logger;
        }

        public abstract string ID();

        public abstract bool Check();

        public abstract bool Enable();

        public abstract bool Disable();

    }
}