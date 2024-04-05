public async Task<string> GetUserAsync()
{
    try
    {
        // Assuming we have a HttpClient instance available
        using (var client = new HttpClient())
        {
            // Set up the HTTP client with necessary headers, etc.
            client.BaseAddress = new Uri("https://www.example.com            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Asynchronously call the API to get the user data
            HttpResponseMessage response = await client.GetAsync("users/1"); // Assuming we're fetching user with ID 1
            if (response.IsSuccessStatusCode)
            {
                // Read the response as a string if the call was successful
                string userData = await response.Content.ReadAsStringAsync();
                return userData;
            }
            else
            {
                // Handle the case when the API call was not successful
                return "Error: Unable to retrieve user data.";
            }
        }
    }
    catch (Exception ex)
    {
        // Handle any exceptions that may have occurred during the API call
        return $"Exception: {ex.Message}";
    }
}
