using BookConsole;
using Newtonsoft.Json;

namespace BookConsole
{
    // A class responsible for connecting to the API
    public class BookApi
    {
        // The main method for retrieving and displaying book information
        public static async Task GetAndDisplayAsync()
        {
            // defining the API URL with search queries and maxResults parameter
            string apiUrl = "https://www.googleapis.com/books/v1/volumes?q=the&maxResults=15";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Sending HTTP GET request to the API
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Checking if the response is successfull
                    if (response.IsSuccessStatusCode)
                    {
                        // reading the response content
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Deserialize the JSON response into an object of type ApiResponse
                        var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseBody);

                        // Checking that the apiResponse/Items are not null
                        if (apiResponse != null && apiResponse.Items != null)
                        {
                            Console.WriteLine("Items:");
                            Console.WriteLine();


                            // Looping through the list of items
                            foreach (var item in apiResponse.Items)
                            {
                                if (item.volumeInfo != null)
                                {

                                    // Displaying information about each book
                                    Console.WriteLine($"Title: {item.volumeInfo.title}");

                                    // Displaying a value if the property does not exists
                                    if (item.volumeInfo.authors == null)
                                    {
                                        Console.WriteLine($"Author(s): N/A");
                                        
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Author(s): {string.Join(", ", item.volumeInfo.authors)}");
                                    }
                                    if (item.volumeInfo.pageCount == 0)
                                    {
                                        Console.WriteLine($"Pages: N/A");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Pages: {item.volumeInfo.pageCount}");
                                    }
                                    
                                    Console.WriteLine($"Published Date: {item.volumeInfo.publishedDate}");
                                    Console.WriteLine($"ISBN: {item.volumeInfo.industryIdentifiers?[0]?.identifier ?? "N/A"}");
                                    Console.WriteLine(); // Adding spacing for readability
                                }
                                else
                                {
                                    Console.WriteLine("No book information found in the item.");
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("No items found in the API response.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Failed to retrieve data. Status code: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
    }
}

