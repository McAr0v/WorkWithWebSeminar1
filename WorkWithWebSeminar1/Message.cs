using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace WorkWithWebSeminar1
{
    internal class Message
    {
        public string Name { get; set; }

        public string Text { get; set; }

        public DateTime Stime { get; set; }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public static Message? FromJson(string message)
        {
            return JsonSerializer.Deserialize<Message>(message);
        }

        public Message (string nik, string text)
        {
            this.Name = nik;
            this.Text = text;
            this.Stime = DateTime.Now;
        }

        public Message () { }

        public override string ToString()
        {
            //return $"Nickname:{this.Name}, Text:{this.Text}, Date:{this.date}";
            return $"Получено сообщение от {Name} ({Stime}): \n {Text}";
        }
    }
}
