using System;
using System.Collections.Generic;
using System.Text;
// BAD, refactor.
using YozuBasicAlgebra.Logging;

namespace YozuBasicAlgebra.TrafficLights
{
    public class RawTrafficLight : ITrafficLight
    {
        private ILogger _logger;

        public RawTrafficLight(ILogger logger)
        {
            _logger = logger;
        }
        #region ITrafficLight
        public LightState CurrentState { get; private set; } = LightState.None;

        public void ProcessMessage(LightMessage message)
        {
            switch (message)
            {
                case LightMessage.Reset:
                    ChangeState(LightState.Red);
                    break;
                case LightMessage.Next:
                    switch (CurrentState)
                    {
                        case LightState.None:
                            ChangeState(LightState.Red);
                            break;
                        case LightState.Red:
                            ChangeState(LightState.RedAmber);
                            break;
                        case LightState.RedAmber:
                            ChangeState(LightState.Green);
                            break;
                        case LightState.Green:
                            ChangeState(LightState.Amber);
                            break;
                        case LightState.Amber:
                            ChangeState(LightState.Red);
                            break;
                        default:
                            throw new ApplicationException("Unexpected state in RawTrafficLight::Next");
                    }
                    break;
                case LightMessage.Dance:
                    throw new ApplicationException("Unexpected message in RawTrafficLight::Next");
                case LightMessage.OtherMessagesGoHere:
                    throw new ApplicationException("Unexpected message in RawTrafficLight::Next");
            }
        }
        #endregion

        private void ChangeState(LightState newState)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Changing state from ");
            sb.Append(CurrentState.ToString());
            sb.Append(" to ");
            sb.Append(newState.ToString());
            sb.Append(Environment.NewLine);

            _logger.Log(sb.ToString());

            CurrentState = newState;
        }
    }
}
