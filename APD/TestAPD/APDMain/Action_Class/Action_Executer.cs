using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Reflection;
using System.Linq;
using Test_Libary;
using System.Threading;
using System.Threading.Tasks;
using APDMain;

namespace TestAPD
{
    class Action_Executer : IAction
    {
        //where we are on the stack
        public int ProgramCounter { get; set; }

        //Parameters the user has entered for their actions
        public object[] Parameters = null;

        //Each item in this list represents a different threads actions
        public List<Threaded_Action> ListofActionThreads;


        public Action_Executer()
        {
            ListofActionThreads = new List<Threaded_Action>();
        }



        //---------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Add the action into one of the instances of "Threaded_Actions.cs" 
        /// </summary>
        /// <param name="ActionDelegate"> method we want to add to stack</param>
        /// <param name="StartOnNewThread"> if true then create a new instance for a new thread, false dont</param>
        public void AddAction(dynamic ActionDelegate, bool StartOnNewThread, object [] Parameters = null)
        {
            try
            {
                Threaded_Action ActiveInstance;

                if (StartOnNewThread)
                {
                    //create new instance
                    ActiveInstance = new Threaded_Action(ProgramCounter);

                    //add method to the stack
                    ActiveInstance.AddAction(ProgramCounter, ActionDelegate, Parameters);

                    //add this isntance to the thread instance list 
                    //so we can add mmore methods to it later
                    ListofActionThreads.Add(ActiveInstance);
                }
                else 
                {
                    #region Create new instance if there arent any in the list
                    // make sure there is an existing instance 
                    if (ListofActionThreads.Count == 0)
                    {
                        //create new instance
                        ActiveInstance = new Threaded_Action(ProgramCounter);

                        //add this isntance to the thread instance list 
                        //so we can add mmore methods to it later
                        ListofActionThreads.Add(ActiveInstance);
                    }
                    #endregion

                    //get the most recent instance  
                    ActiveInstance = ListofActionThreads[ListofActionThreads.Count - 1];

                    //add method to the stack
                    ActiveInstance.AddAction(ProgramCounter, ActionDelegate, Parameters);
                }

                //increment program counter
                ProgramCounter++;
 
            }
            //fail gracefully if unsuccesfull
            catch
            {
                System.Windows.Forms.MessageBox.Show(string.Format("Unable to add action to stack at Program counter pos: {0}", ProgramCounter));
            }
        }

        public async void ExecuteStack(bool Await_IT)
        {
            //for each instance of Threaded_Actions
            foreach (var item in ListofActionThreads)
            {
                if (Await_IT)
                {
                    //wait for the thread to finish before starting the next
                    await Task.Run(() => item.ExecuteStack());
                }
                else
                {
                    //execute items on the stack asyncronously (Without waiting for the previous thread to finish before starting the next one)
                    Task.Run(() => item.ExecuteStack());
                }

            }
        }


        //---------------------------------------------------------------------------------------------------------------------
        //Clears the stack of all items 
        public void ClearStack()
        {
            ListofActionThreads = new List<Threaded_Action>();     
        }


        //get the stack as a string
        public override string ToString()
        {
            string StackData = "";
            int i = 0;
            foreach (var item in ListofActionThreads)
            {
                StackData += string.Format("Pos: {0},  Method:{1}",i, ListofActionThreads[i]);
                i++;
            }
            if (StackData == "")
            {
                StackData = "Nothing found on stack";
            }
            return StackData;
        } 
    }


    //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    class Threaded_Action 
    {
        //contrian the parameters for this instance
        public List<object[]> Parameters { get; set; }
        //contains the actions for this instance
        public Dictionary<int, dynamic> Actions_Stack { get; set;}
        //position on the stack (relative to this instance)
        public int ActionCounter { get; set;}
        //position on the stack (relative to the entire program)
        int PositionOnStack;

        public Threaded_Action(int _PositionOnStack)
        {
            Parameters = new List<object[]>();
            Actions_Stack = new Dictionary<int, dynamic>();
            ActionCounter = 0;
            PositionOnStack = _PositionOnStack;
        }

        //add a method to the instances dictionary
        public void AddAction(int ProgramCounter, dynamic action, object[] _Parameters = null)
        {
            //fail gracefully if unsuccesfull
            try
            {
                Actions_Stack.Add(ProgramCounter, action);  //add action             
                Parameters.Add(_Parameters); //add parameters
                this.ActionCounter++;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(string.Format("Unable to add event {0} to Queue at Programe counter pos: {1} /n" +ex.Message, Actions_Stack, ProgramCounter));
            }
        }

        //----------------------------------------------------------------------------------------------------
        //execute each item in the stack
        public  void ExecuteStack()
        {
            // invoke each method
            for (int i = PositionOnStack; i < PositionOnStack + Actions_Stack.Count; i++)
            {
                //get action 
                dynamic action = Actions_Stack[i];

                //get its permaters
                dynamic Parameters_forThis_action = Parameters[i - PositionOnStack];

                //invoke it 
                invokeActionMethod(action, Parameters_forThis_action);
            }
        }


    


        ///----------------------------------------------------------------------------------------

        public void invokeActionMethod (Action action, object[] parameters)
        {
            action.DynamicInvoke();
        }

        public void invokeActionMethod<T> (Action<T> action, object [] parameters)
        {
            action.DynamicInvoke(parameters);
        }

        public void invokeActionMethod<T1,T2>(Action<T1,T2> action, object[] parameters)
        {
            action.DynamicInvoke(parameters);
        }

        public void invokeActionMethod<T1, T2, T3>(Action<T1, T2, T3> action, object[] parameters)
        {
            action.DynamicInvoke(parameters);
        }

        public void invokeActionMethod<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, object[] parameters)
        {
            action.DynamicInvoke(parameters);
        }

        public void invokeActionMethod<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, object[] parameters)
        {
            action.DynamicInvoke(parameters);
        }

        public void invokeActionMethod<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, object[] parameters)
        {
            action.DynamicInvoke(parameters);
        }

        public void invokeActionMethod<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, object[] parameters)
        {
            action.DynamicInvoke(parameters);
        }

        public void invokeActionMethod<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7,T8> action, object[] parameters)
        {
            action.DynamicInvoke(parameters);
        }


        public void invokeActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, object[] parameters)
        {
            action.DynamicInvoke(parameters);
        }

        public void invokeActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, object[] parameters)
        {
            action.DynamicInvoke(parameters);
        }




    }
}
