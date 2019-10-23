using System;
using System.Collections.Generic;
using System.Text;

namespace YozuBasicAlgebra.TrafficLights
{
    public interface ITrafficLight
    {
        LightState CurrentState { get; }

        void ProcessMessage(LightMessage message);
    }

    public enum LightState
    {
        None = 0,
        Red,
        RedAmber,
        Green,
        Amber
    }

    public enum LightMessage
    {
        Reset = 0,
        Next,
        Dance,
        OtherMessagesGoHere
    }
}
