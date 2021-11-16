using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Revamp
{
    internal class Robot
    {
        public string name;
        public string handGesture;

        public void ChooseGesture(string availableGestures)
        {

        }


        public Robot(string nameOfRobot, string gesturePicked)
        {
            name = nameOfRobot;
            handGesture = gesturePicked;
        }

    }
}
