using System;
using System.Text;

namespace JapaneseThing
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = UTF8Encoding.Unicode;
            System.Console.InputEncoding = UTF8Encoding.Unicode;
            

            TestClass.addWordOrExpression("Translate into English", "こんにちは。", "Hello");
            TestClass.addWordOrExpression("Translate into Japanese", "What time is it now.", "いまなんじですか。");
            TestClass.addWordOrExpression("What is the question asking for", "せんこうはなにですか。", "What is your major");

            TestClass.addWordOrExpression("What is the missing particle", "わたし＿なまえはあおばです。", "の");
            TestClass.addWordOrExpression("What is 4:30 PM in japanese", "", "ごごよじはん。");
            TestClass.addWordOrExpression("Answer in japanese", "あのう、すみません。せんこうはなにですか。", "The question is asking what your major is. For us, we would answer is こんぴゅーたーこうがくです。");

            TestClass.addWordOrExpression("What is the missing particle. This conversation has two people talking.", "わたしのだいがくはじょーじあーさざん。ありすは？\nわたしのたいがく＿じょーじあーさざん。", "This conversation is about their shared college. Alice is the name of the second person. \nも is the correct answer");
            TestClass.addWordOrExpression("Translate into japanese.", "Hello. My name is Murami. Nice to meet you.", "こんにちは。わたしはむらみです。どうぞよろしく。");


            TestClass.beginTest();

        }
    }
}
