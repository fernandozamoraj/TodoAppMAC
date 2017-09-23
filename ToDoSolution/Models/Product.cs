using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassLibrary1.util;

namespace ToDoSolution.Models
{
    public class Product
    {
        private string _Description = "";
        public string Description
        {
            get
            {
                StringHelper sh = new StringHelper();
                
                StringBuilder sb = new StringBuilder();

                string[] tokens = sh.CapitalizeAndSplit(_Description, ' ');

                foreach (var token in tokens)
                {
                    sb.Append(token);
                }

                return sb.ToString();
            }
            set
            {
                _Description = value;
            }
        }
    }
}