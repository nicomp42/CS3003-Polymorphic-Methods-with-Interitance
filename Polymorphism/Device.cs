/*************************************************************
 * Illustrate Polymorphic Methods.                           *
 *                                                           *
 * This is an abstract base class.                           *
 *                                                           *
 *                                                           *
 * Bill Nicholson                                            *
 *************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Device
    {
        private String mID; // We know every device must have a unique identifier

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ID">Unique Identifier of the device</param>
        public Device(String ID) { mID = ID; }

        /// <summary>
        /// ID get and set
        /// </summary>
        public String ID
        {
            get { return mID; } // DO not return ID. That creates an infinite loop
            private set{}        // { mID = ID; }
        }
        // run-time these methods will be called BUT
        // the program will actually call a derived class method.
        public abstract void Start();       // No body
        public abstract void Stop();        // No body
    }
}
