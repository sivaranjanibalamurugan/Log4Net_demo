using Log_Net_Dem0.Alert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_Net_Dem0.DoActions
{
    class DoActions : Base.BaseClass
    {
     
        public static void JS_Alert()
            {
                //Creating the instance of the class
                AlertClass alert = new AlertClass(driver);
                //To select the button 
                alert.jsAlert.Click();
                System.Threading.Thread.Sleep(2000);
                //Accept the confirm button 
                var alert_win = driver.SwitchTo().Alert();
                alert_win.Accept();
                System.Threading.Thread.Sleep(2000);
                // checking for validation 
                Console.WriteLine(alert.clickResult.Text);
                if (alert.clickResult.Text == "You successfully clicked an alert")
                {
                    Console.WriteLine("Alert Text successful");
                }
            }
            public static void test_Confirm()
            {
                //Creating the instance of the class
                AlertClass alert = new AlertClass(driver);
                //To select the button 
                alert.jsConfirm.Click();
                System.Threading.Thread.Sleep(2000);
                //Accept the confirm button 
                var alert_win = driver.SwitchTo().Alert();
                alert_win.Accept();
                System.Threading.Thread.Sleep(2000);
                // checking for validation 
                Console.WriteLine(alert.clickonResult.Text);
                if (alert.clickonResult.Text == "You clicked: Ok")
                {
                    Console.WriteLine("Confirm Text Successful");
                }
            }
            public static void test_Dismiss()
            {
                //Creating the instance of the class
                AlertClass alert = new AlertClass(driver);
                //To select the button 
                alert.jsDismiss.Click();
                System.Threading.Thread.Sleep(2000);
                //Dismiss the confirm button 
                var alert_win = driver.SwitchTo().Alert();
                alert_win.Dismiss();
                System.Threading.Thread.Sleep(2000);
                // checking for validation 
                Console.WriteLine(alert.clickforResult.Text);
                if (alert.clickforResult.Text == "You clicked: Cancel")
                {
                    Console.WriteLine("Dismiss Test Successful");
                }
            }
            public static void test_Promt()
            {
                //Creating the instance of the class
                AlertClass alert = new AlertClass(driver);
                //To select the button 
                alert.jsPrompt.Click();
                System.Threading.Thread.Sleep(2000);
                //Accept the confirm button 
                var alert_win = driver.SwitchTo().Alert();
                alert_win.SendKeys("confirm as Siva");
                alert_win.Accept();
                System.Threading.Thread.Sleep(2000);
                // checking for validation 
                Console.WriteLine(alert.clicktheResult.Text);
                if (alert.clicktheResult.Text == "You entered: confirm as Siva")
                {
                    Console.WriteLine("Accept Text is successful");

                }
                else
                {
                    Console.WriteLine("Not Successful");
                }
            }
    }
}

