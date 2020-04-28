using APDMain.UI_Files.Business_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Libary;
using TestAPD;

namespace APDMain
{
    public partial class Form1 : Form
    {
        //create instance of the Action_executer class
        Action_Executer Action_exe = new Action_Executer();


        //The test methods we will be working with in the ui
        MethodInfo[] MethodsInTest;

        //Buisness logic
        Business_logic Bussiness_logi = new Business_logic();



        public Form1()
        {
            InitializeComponent();

            //get first 8 methods in the class implementing ITest
            MethodsInTest = Bussiness_logi.GetMethods_InAssembly();
            for (int i = 0; i < 8; i++)
            {
                lbMethods.Items.Add(MethodsInTest[i].ToString());
            }
        }



        //-----------------------------------------------------------------------------------------------------------------
        // Add the selected method to the stack of actions
        private void Addtostack_click(object sender, EventArgs e)
        {
            #region  (1) Find out whether to execute on this thread to execute on a diff one
            bool StartOnNewThread = false;
            if (rbDiffThread.Checked)
            {
                StartOnNewThread = true;
            }
            rbSameThread.Checked = true;
            #endregion


            #region (2) Find the Method info for the selected method and add it to the dictionary with the thread no and the parameters    

            int counter = 0;
            // foreach test method 
            foreach (var item in MethodsInTest)
            {
                //if the test method == the one selected by the user
                if (item.ToString() == lbMethods.SelectedItem.ToString())
                {
                    //create an action from this method info 
                    var ActionDelegate = Bussiness_logi.MethodInfo_ToAction(item);

                    //get the parameters the user entered and cast them to their required type
                    object[] Userparameters = GetUserParams(item.GetParameters().Count(), item.GetParameters());

                    //add action to class
                    Action_exe.AddAction(ActionDelegate, StartOnNewThread, Userparameters);
                }
                counter++;
            }
            #endregion

            //(3) display new item in stack window
            lbStack.Items.Add(string.Format("{0}   |   New Thread : {1}", lbMethods.SelectedItem, StartOnNewThread));

            
        }




        //----------------------------------------------------------------------------------------------
        //get the parameters the user entered and cast them to their required type
        private object[] GetUserParams(int ParamsCount, ParameterInfo [] Pinfo)
        {
            object[] parameters = new object[ParamsCount]; 
 
            for (int i = 1; i <= ParamsCount; i++)
            {
                if (i == 1)
                {
                    //get the type of the paramter
                    Type t = Pinfo[0].ParameterType;
                    //cast the current value to that type
                    parameters[0] = Convert.ChangeType((object)tbparam1.Text, t);
                }
                if (i == 2)
                {
                    Type t = Pinfo[1].ParameterType;
                    parameters[1] = Convert.ChangeType((object)tbparam2.Text, t);
                }
                if (i == 3)
                {
                    Type t = Pinfo[2].ParameterType;
                    parameters[2] = Convert.ChangeType((object)tbparam3.Text, t);
                }
            }

            return parameters;
        }

        //------------------------------------------------------------------------------------------------
        //call execute 
        private void btnExecute_CLick(object sender, EventArgs e)
        {
            Console.WriteLine("-----------------------------------");
            Action_exe.ExecuteStack(cbAwait.Checked);        
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Action_exe = new Action_Executer();
            lbStack.Items.Clear();
        }


        private void rbSameThread_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
