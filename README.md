Project is based around movies and books. 
Movie API: https://www.omdbapi.com/
Books API: https://openlibrary.org/

I used this video to learn how to use async with api, Httpclients, and adding service class into the program class: https://www.youtube.com/watch?v=WxgYDAU4Ppw 

HttpClient: https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient.-ctor?view=net-9.0
logo: [design.com](http://design.com) 
icons: https://fontawesome.com/start 
compare ints: [https://learn.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-9.0#system-array-sort(system-array)](https://learn.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-9.0#system-array-sort(system-array))
enums in c#: https://www.w3schools.com/cs/cs_enums.php
abstract and interface classes: https://www.geeksforgeeks.org/c-sharp/difference-between-abstract-class-and-interface-in-c-sharp/ - inheriting methods for get data api , and httpclient

Features: 
-Arrays & Lists: Books and movies
-Booleans: To check if favourite book, books can be added to favourites(cannot be added more than once)
-Enums: Attempt of using enums for checking the ebook type has been left in the code, but not working.
-Sorting & Comparison: Books can be sorted by Title or by Year. 
-Abstract classes & interfaces: Service abstract base class that has the basic implementation of httpclient and getAPIData, this is used within the books and movie services classes. 
-I also used an abstract interface class to implement the basic getAPIData method. 
-Testing: Testing for movie and book api data, user input, and the add to favourites methods
