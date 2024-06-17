using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Utility
{
    public class BitmapSaver
    {
        // Save method: Serialize Bitmaps to a file
        public static void SaveBitmaps(List<Bitmap> bitmaps, string filePath)
        {
            try
            {
                // Create a formatter object
                BinaryFormatter formatter = new BinaryFormatter();

                // Create a file stream to write to the specified file
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    // Serialize each bitmap and write it to the file
                    foreach (Bitmap bitmap in bitmaps)
                    {
                        formatter.Serialize(fs, bitmap);
                    }
                }

                Console.WriteLine("Bitmaps saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving bitmaps: {ex.Message}");
            }
        }

        // Load method: Deserialize Bitmaps from a file
        public static List<Bitmap> LoadBitmaps(string filePath)
        {
            List<Bitmap> bitmaps = new List<Bitmap>();

            try
            {
                // Create a formatter object
                BinaryFormatter formatter = new BinaryFormatter();

                // Create a file stream to read from the specified file
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    // Deserialize each bitmap from the file
                    while (fs.Position < fs.Length)
                    {
                        Bitmap bitmap = (Bitmap)formatter.Deserialize(fs);
                        bitmaps.Add(bitmap);
                    }
                }

                Console.WriteLine("Bitmaps loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading bitmaps: {ex.Message}");
            }

            return bitmaps;
        }
    }
}

