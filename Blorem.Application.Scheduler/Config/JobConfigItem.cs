using Quartz;

namespace Blorem.Application.Scheduler.Config{

    public class JobConfigItem
    {

        public JobConfigItem(ITrigger trigger, IJobDetail job)
        {
            Trigger = trigger;
            Job = job;
        }

        public ITrigger Trigger { get; private set; }

        public IJobDetail Job { get; private set; }

    }


}