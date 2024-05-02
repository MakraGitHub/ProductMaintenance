using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProductMaintenance.classes
{
   public static class Validator
    {

       private static string title = "Entry Error";
       public static string Title
       {
           get { return title; }
           set { title = value;}
       }

       public static bool IsPresent(TextBox textBox)
       {
           if (textBox.Text == "")
           {
               MessageBox.Show(textBox.Tag + "is required field.",
                   Title);
               textBox.Focus();
               return false;
           }
           return true;
       }
       public static bool IsDecimal(TextBox textBox)
       {
           try{
               Convert.ToDecimal(textBox.Tag);
               return true;

           }catch(FormatException){
               MessageBox.Show(textBox.Tag + "must be decimal number.",Title);
               textBox.Focus();
               return false;

           }
       }      
    }
}
