using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var tester = new MediaTester();
            var mp3 = new MP3player();
            var mp4 = new MP4Player();

            var mp3Delegate = new MediaTester.TestMedia(mp3.PlayMP3File);
            var mp4Delegate = new MediaTester.TestMedia(mp4.PlayMP4File);

            tester.runTest(mp3Delegate);
            tester.runTest(mp4Delegate);

        }
    }
}
