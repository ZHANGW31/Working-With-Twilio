using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.IO;

namespace Working_With_Twilio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var accountSid = Environment.GetEnvironmentVariable("TWILIO_ACC_SID");
            var authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_KEY");

           

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Hi there!",
                from: new Twilio.Types.PhoneNumber(""),
                to: new Twilio.Types.PhoneNumber(Environment.GetEnvironmentVariable(""))
            );

            Console.WriteLine(message.Sid);
        }
    }
}
