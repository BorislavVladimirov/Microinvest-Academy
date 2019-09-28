using SimpleAndSecuredNotepad.Common;
using SimpleAndSecuredNotepad.Interfaces;
using SimpleAndSecuredNotepad.Models;
using System;
using System.Collections.Generic;

namespace SimpleAndSecuredNotepad
{
    public class NotepadDemo
    {
        static void Main(string[] args)
        {
            List<IPage> pages = new List<IPage>();

            try
            {
                GeneratePages(pages);

                TestFunctionality(pages);               

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void TestFunctionality(List<IPage> pages)
        {
            //testing pages 
            Console.WriteLine(string.Format("{0} {1}", GlobalConstants.ContainigGivenWord, pages[6].ContainsDigits()) + Environment.NewLine);
            Console.WriteLine(string.Format("{0} {1}", GlobalConstants.ContainigDigit, pages[2].ContainsDigits()) + Environment.NewLine);
            Console.WriteLine(string.Format("{0} {1}", GlobalConstants.ContainigGivenWord, pages[5].SearchWord("maximus")) + Environment.NewLine);
            Console.WriteLine(string.Format("{0} {1}", GlobalConstants.ContainigDigit, pages[6].ContainsDigits()) + Environment.NewLine);

            IPage pageOne = pages[0];
            pageOne.AddText("Testing!!!");
            Console.WriteLine(pageOne.BrowsePage());
            pageOne.DeleteText();
            Console.WriteLine(pageOne.BrowsePage());
            pageOne.AddText("Working fine after deleting.");
            Console.WriteLine(pageOne.BrowsePage());

            //Testing "secure password needed" for securedNotepad
            //ISecuredNotepad securedNotepad = new SecuredNotepad(pages, "securedPassword");

            //Trying to use methods in secured notepad with wrong password
            //securedNotepad.AddText(2, "Maecenas eu mauris nec felis feugiat placerat ut quis lacus.", "isThisTheRightPassWord");

            INotepad simpleNotepad = new SimpleNotepad(pages);
            ISecuredNotepad securedNotepad1 = new SecuredNotepad(pages, "PassWord1");
            ISecuredNotepad notepad = new SecuredNotepad(pages, "11111Ab");

            // testing notepads
            Console.WriteLine(notepad.BrowsePage("11111Ab"));
            Console.WriteLine(simpleNotepad.SearchWord("lorem"));
            Console.WriteLine(string.Format("{0} {1}", GlobalConstants.ContentForPagesWithDigits, simpleNotepad.PrintAllPagesWithDigits()));
            Console.WriteLine(simpleNotepad.PrintAllPagesWithDigits());
            simpleNotepad.ReplaceText(5, "i'm the new text !");
            Console.WriteLine(simpleNotepad.PrintAllPagesWithDigits());

            //testing Electronic secured notepad
            ElectronicSecuredNotepad electronicSecuredNotepad = new ElectronicSecuredNotepad(pages, "coolPassword");

            //Trying to use funtionality of electronic secured notepad before switching it on
            //electronicSecuredNotepad.AddText(1, "some text", "coolPassword");

            electronicSecuredNotepad.Start();
            electronicSecuredNotepad.AddText(9, "adding some text", "coolPassword");
            Console.WriteLine(electronicSecuredNotepad.BrowsePage("coolPassword"));
            electronicSecuredNotepad.DeleteText(1, "coolPassword");
            electronicSecuredNotepad.ReplaceText(2, "new text", "coolPassword");
            Console.WriteLine(electronicSecuredNotepad.BrowsePage("coolPassword"));
            electronicSecuredNotepad.Stop();
        }

        private static void GeneratePages(List<IPage> pages)
        {
            IPage pageOne = new Page("Chapter one");

            pageOne.AddText("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc mauris metus, faucibus eu sapien ac," +
                " pulvinar euismod nisi. Sed congue mollis orci, sed placerat quam mattis ut." +
                " Nam suscipit, eros nec pharetra tincidunt, purus nulla mollis lorem, " +
                "quis fringilla massa lorem ac ligula. ");

            pages.Add(pageOne);


            IPage pageTwo = new Page("Charpter two");

            pageTwo.AddText("Proin varius felis at accumsan ullamcorper. Phasellus eu tortor ut nulla hendrerit fringilla." +
                " Mauris blandit mollis lorem ac convallis. Suspendisse potenti. Pellentesque maximus egestas volutpat." +
                " Suspendisse vestibulum interdum eros quis viverra. Fusce sed quam ac leo fermentum condimentum. ");

            pages.Add(pageTwo);


            IPage pageThree = new Page("Charpter three");

            pageThree.AddText("Curabitur lacinia tristique massa, et ultrices arcu dictum quis. Sed in ex ligula. " +
                "Aliquam sagittis tortor ut feugiat tincidunt. In rutrum felis quis arcu luctus vestibulum." +
                " Proin maximus velit volutpat, egestas neque quis, semper ex. Aliquam non malesuada est, et egestas ligula");

            pages.Add(pageThree);


            IPage pageFour = new Page("Charpter four");

            pageFour.AddText("Suspendisse nisl libero, maximus luctus orci ut, cursus blandit felis. Cras malesuada erat " +
                "sollicitudin magna gravida, eget placerat turpis posuere. Proin fermentum dui sed velit finibus sollicitudin. " +
                "Vivamus sit amet lacinia augue. Nulla at risus elit. Nunc blandit purus vitae sodales rutrum.");

            pages.Add(pageFour);


            IPage pageFife = new Page("Charpter five");

            pageFife.AddText("Donec sed sollicitudin nibh. 223Duis lorem nibh, blandit ac quam ut, ultrices mattis ante." +
                " Praesent aliquet massa eu efficitur euismod223. Phasellus tincidunt tincidunt felis.. ");

            pages.Add(pageFife);


            IPage pageSix = new Page("Charpter six");

            pageSix.AddText("Nullam sagittis ultrices nulla, eu luctus turpis dignissim in. Praesent et arcu sit amet sapien commodo maximus. " +
                "Aliquam at efficitur nisi. Mauris fringilla vestibulum eros, at faucibus dui varius quis. Nunc facilisis neque ligula, " +
                "non ultrices sapien consequat id. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae");

            pages.Add(pageSix);


            IPage pageSeven = new Page("Charpter seven");

            pageSeven.AddText("12Mauris congue lorem ac risus feugiat condimentum. Nullam lobortis eu libero et viverra." +
                " Donec pharetra aliquam erat quis hendrerit. Pellentesque consequat interdum tortor, nec auctor sapien molestie sit amet." +
                " Sed at augue rhoncus, facilisis est dignissim, faucibus nisl. ");

            pages.Add(pageSeven);


            IPage pageEight = new Page("Charpter eight");

            pageEight.AddText("Sed vel aliquet tellus, et lacinia erat. Pellentesque cursus odio cursus enim consectetur, nec pellentesque" +
                " neque porttitor. Nam a convallis mi. Pellentesque sed metus ac urna tincidunt rhoncus.");

            pages.Add(pageEight);


            IPage pageNine = new Page("Charpter nine");

            pageNine.AddText("Mauris luctus ex est, quis posuere massa varius laoreet. Orci varius natoque penatibus et magnis dis " +
                "parturient montes, nascetur ridiculus mus. Nulla efficitur mi ac feugiat porttitor. Suspendisse pellentesque tortor " +
                "ac ultrices dapibus. Aenean pulvinar nisl enim, ut facilisis libero ullamcorper eget. Sed vulputate mauris in libero " +
                "aliquet fringilla. Donec id ultrices felis. ");

            pages.Add(pageNine);


            IPage pageTen = new Page("Charpter ten");

            pageTen.AddText("Ut orci odio, sagittis sit amet eleifend quis, eleifend eget nisl. Donec blandit massa id augue " +
                "viverra accumsan. Sed quis tincidunt elit. Cras ullamcorper, felis a facilisis vestibulum, lorem dui tempor ex, " +
                "sit amet eleifend enim libero et ipsum. Duis porttitor euismod commodo.");

            pages.Add(pageTen);
        }
    }
}
