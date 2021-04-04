using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;

namespace FaceToWork_Console
{
	class Program
	{
		const string subskey = "<tvuj klic>";
		const string endpoint = "<tvuj endpoint>";

		static void Main(string[] args)
		{
			IFaceClient client = Authenticate(endpoint, subskey);
		}
	}
}
