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
		const string IMAGE_BASE_URL = "https://raw.githubusercontent.com/lexa105/Azure-Cup-FaceToWork/main/obrazky/";

		const string SUBSCRIPTION_KEY = "<subscription key>";
		const string ENDPOINT = "<endpoint>";


		static void Main(string[] args)
		{


			// rozpoznavaci modely neboli RECOGNITION MODELY jsou modely na rozpoznavani tvari pomoci Azure.
			// Celkove jich je 4. Kazdy vysel v jinej rok. Obecne je lepsi pouzivat nejnovejsi RECOGNITION MODEL.
			// RECOGNITION je pro pouziti pri POROVNANI nebo IDENTIFIKACI nikoliv pro DETEKCI obliceju
			
			
			// Recognition model 4 je nejlepsi protoze dokaze rozeznat registrovane tvare pres masky.
			const string RECOGNITION_MODEL = RecognitionModel.Recognition04;

			// Large Face List - Je seznam jakychkoliv obliceju seznam je ulozen na serveru dokud nebude smazan FaceList - Delete
			const string LargeFaceListId = "mylargefacelistid_01"; // tyto id nazvy musi byt pojmenovana malymi pismeny
			const string LargeFaceList = "MyLargeFaceListName";


			//Prikazy ktere se pouziji


			// Authentikace uzivatele.
			IFaceClient faceClient = Authenticate(ENDPOINT, SUBSCRIPTION_KEY);

			DetectFaceExtract(faceClient, IMAGE_BASE_URL, RECOGNITION_MODEL).Wait();

		}

		public static IFaceClient Authenticate(string endpoint, string key)
		{
			return new FaceClient(new ApiKeyServiceClientCredentials(key)) { Endpoint = endpoint };
		}

		public static async Task DetectFaceExtract(IFaceClient client, string url, string recognitionModel)
		{
			Console.WriteLine("=========DETEKUJI OBLICEJE=========");
			Console.WriteLine();

			List<string> imageFileNames = new List<string>			//Vytvori List<> jmenem imageFileNames
			{
				"JBGrande.jpg", // Justin Bieber a Ariana Grande
				"elon-musk.jpeg"// The God Elon Musk
			};

			foreach (var imageFileName in imageFileNames)   // pro kazdy 'imageFileName' se udela dalsi list Detected Face
			{
				IList<DetectedFace> detectedFaces;

				detectedFaces = await client.Face.DetectWithUrlAsync($"{url}{imageFileName}", true, false, returnFaceAttributes: new List<FaceAttributeType> { FaceAttributeType.Age,
					FaceAttributeType.Gender }, recognitionModel: recognitionModel, detectionModel: DetectionModel.Detection01);

				Console.WriteLine();
				Console.WriteLine($"{detectedFaces.Count} faces detected from image {imageFileName}.");
				Console.WriteLine();

				foreach (var detectedFace in detectedFaces)
				{
					
					Console.WriteLine($"Rectangles(Left/Top/Width/Height) : {detectedFace.FaceRectangle.Left} {detectedFace.FaceRectangle.Top} {detectedFace.FaceRectangle.Width} {detectedFace.FaceRectangle.Height}" +
						$"	ID: {detectedFace.FaceId}");
				};
			};

			
			
			
		}
	}
}
