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

		const string SUBSCRIPTION_KEY = "1bb9e797051348698dc5c58a509646c8";
		const string ENDPOINT = "https://facetowork-endpoint.cognitiveservices.azure.com/";


		static void Main(string[] args)
		{


			// rozpoznavaci modely neboli RECOGNITION MODELY jsou modely na rozpoznavani tvari pomoci Azure.
			// Celkove jich je 4. Kazdy vysel v jinej rok. Obecne je lepsi pouzivat nejnovejsi RECOGNITION MODEL.
			// RECOGNITION je pro pouziti pri POROVNANI nebo IDENTIFIKACI nikoliv pro DETEKCI
			
			// Recognition model 4 je nejlepsi protoze dokaze rozeznat registrovane tvare pres masky.
			const string RECOGNITION_MODEL = RecognitionModel.Recognition04;

			// Large Face List - Je seznam jakychkoliv obliceju seznam je ulozen na serveru dokud nebude smazan FaceList - Delete
			const string LargeFaceListId = "mylargefacelistid_01"; // tyto id nazvy musi byt pojmenovana malymi pismeny
			const string LargeFaceList = "MyLargeFaceListName";


			//Prikazy ktere se pouziji


			// Authentikace uzivatele.
			IFaceClient faceClient = Authenticate(ENDPOINT, SUBSCRIPTION_KEY);

			try
			{
				FindSimilar(faceClient, IMAGE_BASE_URL, RECOGNITION_MODEL).Wait();
			}
			catch (APIErrorException e)
			{
				Console.WriteLine(e.Message);
			}
		}

		public static IFaceClient Authenticate(string endpoint, string key)
		{
			return new FaceClient(new ApiKeyServiceClientCredentials(key)) { Endpoint = endpoint };
		}

		public static async Task DetectFaceExtract(IFaceClient client, string url, string recognitionModel)
		{
			Console.WriteLine("=========DETEKUJI OBLICEJE=========");
			Console.WriteLine();

			List<string> imageFileNames = new List<string>
			{
				"JBGrande.jpg", // Justin Bieber a Ariana Grande
				"elon-musk.jpeg"
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
						$"	ID: {detectedFace.FaceId}		Age: {detectedFace.FaceAttributes.Age}   Gender: {detectedFace.FaceAttributes.Gender}");
				}
				Console.WriteLine();
			}

		}

		private static async Task<List<DetectedFace>> DetectFaceRecognize(IFaceClient faceClient, string url, string recognition_model)
		{
			IList<DetectedFace> detectedFaces = await faceClient.Face.DetectWithUrlAsync(url, recognitionModel: recognition_model, detectionModel: DetectionModel.Detection03);
			Console.WriteLine($"{detectedFaces.Count} faces found in {Path.GetFileName(url)}");
			return detectedFaces.ToList();


		}

		public static async Task FindSimilar(IFaceClient faceClient, string url, string recognition_model)
		{
			Console.WriteLine("=====Find Similar Faces=====");
			Console.WriteLine();


			List<string> TargetImageFileNames = new List<string>
			{
							"JBGrande.jpg",
							"elon1.jpg",
							"elon2.jpg",
							"elon3.jpg",
							"billgates.jpg",
							"poki.jpg",
							"rock.jpg"
			};

			string sourceImage = "elon-musk.jpeg";
			IList<Guid?> targetFaceIds = new List<Guid?>();

			foreach (var TargetFileName in TargetImageFileNames)
			{
				//detekuje vsechny tvare z target obrazku
				var faces = await DetectFaceRecognize(faceClient, $"{url}{TargetFileName}", recognition_model);
				//prida ID detekovanych obliceju do listu, ktery jsme nahore vytvorili "targetFaceIds"
				targetFaceIds.Add(faces[0].FaceId.Value);
			}
			// Detect faces from source image url.
			IList<DetectedFace> detectedFaces = await DetectFaceRecognize(faceClient, $"{url}{sourceImage}", recognition_model);
			
			

			// Find a similar face(s) in the list of IDs. Comapring only the first in list for testing purposes.
			IList<SimilarFace> similarResults = await faceClient.Face.FindSimilarAsync(detectedFaces[0].FaceId.Value, null, null, targetFaceIds);

			
			// </snippet_find_similar>
			// <snippet_find_similar_print>
			foreach (var similarResult in similarResults)
			{
				Console.WriteLine($"Faces from {sourceImage} & ID:{similarResult.FaceId} are similar with confidence: {similarResult.Confidence}.");

			}
			
		}
	}
}
