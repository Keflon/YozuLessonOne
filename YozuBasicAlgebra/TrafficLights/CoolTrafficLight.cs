using System;
using System.Collections.Generic;
using System.Text;
using YozuBasicAlgebra.Liskov;
using FunctionZero.StateMachineZero;

namespace YozuBasicAlgebra.TrafficLights
{
    public class CoolTrafficLight : ITrafficLight
    {
        private ILogger _logger;
        private StateMachine<LightState, LightMessage> _machine;

        public CoolTrafficLight(ILogger logger)
        {
            _logger = logger;

            _machine = new StateMachine<LightState, LightMessage>(LightState.Red);

            _machine.Add(LightState.Red, LightMessage.Next, LightState.RedAmber);
            _machine.Add(LightState.RedAmber, LightMessage.Next, LightState.Green);
            _machine.Add(LightState.Green, LightMessage.Next, LightState.Amber);
            _machine.Add(LightState.Amber, LightMessage.Next, LightState.Red);

            _machine.Add(LightState.Red, LightMessage.Reset, LightState.Red);
            _machine.Add(LightState.RedAmber, LightMessage.Reset, LightState.Red);
            _machine.Add(LightState.Green, LightMessage.Reset, LightState.Red);
            _machine.Add(LightState.Amber, LightMessage.Reset, LightState.Red);

            _machine.StateChanged += _machine_StateChanged;

            _machine.UnknownStateTransition += _machine_UnknownStateTransition;
        }

        private void _machine_StateChanged(object sender, StateChangedEventArgs<LightState> e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Changing state from ");
            sb.Append(e.OldState.ToString());
            sb.Append(" to ");
            sb.Append(e.NewState.ToString());
            sb.Append(Environment.NewLine);

            _logger.Log(sb.ToString());
        }

        private void _machine_UnknownStateTransition(object sender, UnknownStateTransitionEventArgs<LightState, LightMessage> e)
        {
            _logger.Log("State transition error blah");
        }

        #region ITrafficLight
        public LightState CurrentState { get; private set; } = LightState.None;

        public void Next()
        {
            _machine.EnqueueMessage(LightMessage.Next);
        }

        public void Reset()
        {
            _machine.EnqueueMessage(LightMessage.Reset);
        }
        #endregion
    }
}
