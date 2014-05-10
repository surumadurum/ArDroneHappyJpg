namespace AR.Drone.Client.Command
{
    public class AnimationCommand : AtCommand
    {
        private readonly int _type;
        private readonly int _duration;

        public AnimationCommand(int type, int duration)
        {
            _type = type;
            _duration = duration;
        }

        protected override string ToAt(int sequenceNumber)
        {
            return string.Format("AT*ANIM={0},{1},{2}\r", sequenceNumber,_type,_duration);
        }
    }
}