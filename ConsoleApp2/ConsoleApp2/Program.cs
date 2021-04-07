using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;

namespace ConsoleApp2
{

	class Program
	{
		// pouzito pro Identifikovani 
		static string personGroupId = Guid.NewGuid().ToString();


		//Konstatni "string" pro "Image URL"
		const string IMAGE_BASE_URL = "<Dej sem URL>";

		const string SUBSCRIPTION_KEY = "<subscription key>";
		const string ENDPOINT = "<endpoint>";


		static void Main(string[] args)
		{
			// rozpoznavaci modely neboli RECOGNITION MODELY jsou modely na rozpoznavani tvari pomoci Azure.
			// Celkove jich je 4. Kazdy vysel v jinej rok. Obecne je lepsi pouzivat nejnovejsi RECOGNITION MODEL.
			// RECOGNITION je pro pouziti pri POROVNANI nebo IDENTIFIKACI nikoliv pro DETEKCI
			
			// Recognition model 4 je nejlepsi protoze dokaze rozeznat registrovane tvare pres masky.
			const string RECOGNITION_MODEL = RecognitionModel.Recognition04;

			// Large Face List - Je seznam jakychkoliv obliceju seznam je ulozen na serveru dokud nebude smazan FaceList - Delete
			const string KOURIM CURAKY
		}
	}
}
