using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    public class Memo
    {
        public string id { get; set; }
        public string Text { get; set; }
        public decimal priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="oneLine">TRUE WILL PRINT ON ONE LINE ONLY.</param>
        /// <returns>THE FORMATTED STRING.</returns>
        public string PrintMemo(bool oneLine)
        {
            //Not using oneLine for now.
            return String.Format("Id: {0}, Text{1}, priority{2}", this.id, this.Text, this.priority);
        }
    }
}