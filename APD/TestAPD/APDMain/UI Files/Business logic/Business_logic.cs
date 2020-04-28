using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test_Libary;

namespace APDMain.UI_Files.Business_logic
{
    class Business_logic
    {

        //convert method info into an action
        public dynamic MethodInfo_ToAction(MethodInfo item)
        {
            //use param info to determine number of parameters 
            int Param_No = item.GetParameters().Count();
            dynamic Action_;

            //create the delegate based on no of params, i only did 3 as my system only accepts up to 3, the class does not have this limit
            switch (Param_No)
            {
                case 0:
                    //create an action from this method info 
                    Action_ = (Action)Delegate.CreateDelegate(typeof(Action), item);
                    break;
                default:
                    Action_ = CreateTypedAction(item);
                    break;
            }

            return Action_;
        }


        public dynamic CreateTypedAction(MethodInfo item)
        {
            //get all parameter types
            ParameterInfo[] pinfo = item.GetParameters();
            Type[] ParameterTypes = new Type[item.GetParameters().Count()];


            // add the parameters to an array
            int i = 0;
            foreach (dynamic Paramter in pinfo)
            {
                ParameterTypes[i] = Paramter.ParameterType;
                i++;
            }


            //create the action type (Action<string>) using the parameter types
            Type actionT = CreateActionType(ParameterTypes);

            //create the delegate
            dynamic Action_ = Delegate.CreateDelegate(actionT, item);
            return Action_;
        }




        //-------------------------------------------------------------------------------------------------
        //determine its type based on its parameters
        private Type CreateActionType(Type[] parameterTypes)
        {
            Type ActionType = null;
            switch (parameterTypes.Count())
            {
                case 0:
                    return typeof(Action<>).MakeGenericType(parameterTypes);

                case 1:
                    return typeof(Action<>).MakeGenericType(parameterTypes);

                case 2:
                    return typeof(Action<,>).MakeGenericType(parameterTypes);

                case 3:
                    return typeof(Action<,,>).MakeGenericType(parameterTypes);

                case 4:
                    return typeof(Action<,,,>).MakeGenericType(parameterTypes);
                default:
                    return ActionType;
            }
        }

        //-------------------------------------------------------------------------------------------------
        //get all the methods in an assembly
        public MethodInfo[] GetMethods_InAssembly()
        {
            //get types in current assembly
            Type[] Ass_Types = Assembly.GetExecutingAssembly().GetTypes();
            MethodInfo[] MethodsInTest = null;

            foreach (var type in Ass_Types)
            {
                if (type == typeof(TestsMethods))
                {
                    // initialize size of array
                    MethodsInTest = new MethodInfo[type.GetMethods().Count()];
                    //fill array
                    MethodsInTest = type.GetMethods();
                    break;
                }
            }

            //return methods array
            return MethodsInTest;
        }

        //-------------------------------------------------------------------------------------------------


    }
}
