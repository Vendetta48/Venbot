# Venbot
Supraball Meme Bot
using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venbot2
{
    class MyBot
    {
        DiscordClient discord;
        CommandService commands;
        Random rand;


        string[] lbquotes;
        string[] ron;
        string[] argon;
        string[] shado;
        string[] inph;
        string[] juan;
        string[] ven;



        public MyBot()
        {
            rand = new Random();

            lbquotes = System.IO.File.ReadAllLines(@"C:\Users\Vendetta48\Documents\Visual Studio 2017\Projects\Venbot2\Venbot2\lbquotes\lb.array.txt");
            System.Console.WriteLine("Contents of lb.array.txt = ");
            foreach (string lbquotes in lbquotes)
            {
                Console.WriteLine(lbquotes);
            };
            shado = new string[]
            {

                "id put that shit back in ur cute little ass",
                "What the fuck did you just fucking say about me, you little bitch? I'll suck your cock and your eyeball at the same time. I graduated into this specific technique and I'm ready to use it on you whenever you want shit to happen. You're just a little scrub I'm ready to scrub whenever I finish sucking that little small invisible to an eyeball dickhole of yours. If you don't excuse yourself in the next 10 quintillion milliseconds, I swear to god I'll kick ur ass to Mars and I'll jump on you till you run out of oxygen"


            };

            inph = new string[]
                {
                "The most time consuming stuff is testing one handed after you figure something good out and need to fap"

                };

            juan = new string[]
            {
                "i dont play weird bling games but i show them my huge cock",
                "i just hung a bird feeder on a window for my cats.  youre better off than me, theyve been getting up between 3-4 this time of year i hope they spot it, so i know itll be good birds not pigeons",
                "btw i worked for a moving co one summer and drove a truck under a bridge that was too low on my last day haha not on purpose",
                "i promise i wont rape sane but i cant speak for anyone else",
                "who would want to rape sane? it can be consensual",
                "i havent even gotten one mom pic",
                "this is the worst dating site ever",
                "ive been on this discord for awhile now and not a single date"
            };

            ven = new string[]
            {
                "Did you ever hear the tragedy of Darth Vendetta the Hacker? It’s a supralegend. Darth Vendetta was a Dark Lord of the posts, so high and so lit, he could use the Force to influence the supraball to create…post saves. He had such a knowledge of the Keeper Side, he could even keep the ones he cared about…from being scored upon. He became so good, the only thing he was afraid of was losing his hacks…which, eventually of course, he did. Unfortunately, he taught his SHADO everything he knew. Then his SHADO uninstalled his hacks while he was sleeping. Ironic.He could save others from being scored upon…but not himself"

            };

            ron = new string[]
            {
                "ronimages/Ron1.png",
                "ronimages/Ron2.png",
                "ronimages/Ron3.png",
                "ronimages/Ron4.jpg",
                "ronimages/Ron5.png",
                "ronimages/Ron6.png",
                "ronimages/Ron7.png" ,
                "ronimages/Ron8.png",
                "ronimages/Ron9.jpg"


            };
            argon = new string[]
            {
                "argonimages/Argon.png",


            };
            discord = new DiscordClient(x =>
            {
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = Log;
            });
            discord.UsingCommands(x =>
           {
               x.PrefixChar = '.';
               x.AllowMentionPrefix = true;

           });

            commands = discord.GetService<CommandService>();
            RegisterCommand();
            RegisterRonCommand();
            RegisterArgonCommand();
            RegisterShadoCommand();
            RegisterInphCommand();
            RegisterJuanCommand();
            RegisterVenCommand();

            commands.CreateCommand("hello")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("HI!");
                });
            discord.ExecuteAndWait(async () =>
            {
                
            });
        }
        private void RegisterCommand()
        {
            commands.CreateCommand("lb")
                .Do(async (e) =>
                {
                    int randomlbquote = rand.Next(lbquotes.Length);
                    string lbQuotesToPost = lbquotes[randomlbquote];
                    await e.Channel.SendMessage(lbQuotesToPost);
                });

        }
        private void RegisterRonCommand()
        {
            commands.CreateCommand("ron")
                .Do(async (e) =>
                {
                    int randomRonIndex = rand.Next(ron.Length);
                    string ronImages = ron[randomRonIndex];
                    await e.Channel.SendFile(ronImages);

                });

        }
        private void RegisterArgonCommand()
        {
            commands.CreateCommand("argon")
            .Do(async (e) =>
        {
            int randomArgonIndex = rand.Next(argon.Length);
            string argonImages = argon[randomArgonIndex];
            await e.Channel.SendFile(argonImages);


        });
        }

        private void RegisterShadoCommand()
        {
            commands.CreateCommand("shado")
                .Do(async (e) =>

        {
            int randomShadoIndex = rand.Next(shado.Length);
            String shadoQuotes = shado[randomShadoIndex];
            await e.Channel.SendMessage(shadoQuotes);

        });
        }

        private void RegisterInphCommand()
        {
            commands.CreateCommand("inph")
                .Do(async (e) =>

                {
                    int randomInphIndex = rand.Next(inph.Length);
                    String inphQuotes = inph[randomInphIndex];
                    await e.Channel.SendMessage(inphQuotes);

                });
        }
        private void RegisterJuanCommand()
        {
            commands.CreateCommand("juan")
                .Do(async (e) =>
                {
                    int randomJuanIndex = rand.Next(juan.Length);
                    string juanQuotes = juan[randomJuanIndex];
                    await e.Channel.SendMessage(juanQuotes);

                });

        }

        private void RegisterVenCommand()
        {
            commands.CreateCommand("ven")
                .Do(async (e) =>
                {
                    int randomVenIndex = rand.Next(ven.Length);
                    string venMemes = ven[randomVenIndex];
                    await e.Channel.SendMessage(venMemes);

                });

        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

      
    }
}
