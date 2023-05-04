using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Notification
    {

        public static int ID { get; set; } = 0;
        public int id { get; set; } = 0;
        public string? Text { get; set; }
        public DateTime? SentTime { get; set; }
        public string? FromWho { get; set; }

        // => Constructor of `Notification` class
        public Notification(string? text, DateTime? sentTime, string? fromWho)
        {
            id = ++ID;
            Text = text;
            SentTime = sentTime;
            FromWho = fromWho;
        }

        // => Overriding `ToString()` function
        public override string ToString()
        {
            return $"ID: {id}\nText: {Text}\nSent Time: {SentTime}\nFrom: {FromWho}";
        }
    }
}
