using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace APDMain
{
    interface IAction
    {
        //Add the action into one of the instances of "Threaded_Actions.cs" 
        void AddAction(dynamic ActionDelegate, bool StartOnNewThread, object[] Parameters = null);

        //Execute each of the instances of "Threaded_Actions.cs" in ListofActionThreads
        void ExecuteStack(bool Await_IT);


    }
}
