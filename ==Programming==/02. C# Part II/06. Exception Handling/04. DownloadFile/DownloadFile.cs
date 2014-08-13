// 04. Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
//     and stores it the current directory. Find in Google how to download files in C#.
//     Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        WebClient fileDownload = new WebClient();

        string imageAddress = "http://www.devbg.org/img/Logo-BASD.jpg";
        string downloadDestination = @"%UserProfile%\Desktop\";

        try
        {
            fileDownload.DownloadFile(imageAddress, downloadDestination);
        }
        catch (WebException)
        {
            Console.WriteLine("Problem with The Image Download!\n");
        }
        catch (NotSupportedException unsupException)
        {
            Console.WriteLine(unsupException.Message);
        }
        catch (Exception)
        {
            Console.WriteLine("Image can't be Downloaded. Unknown Error!\n");
        }
    }
}

