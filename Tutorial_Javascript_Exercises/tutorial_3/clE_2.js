/*
 * The Music industry has many genres (Pop, Blues, Jazz, Reggae, Rap etc). Implement a hierarchical
 * inheritance structure that has a base Class MusicGenres and any 3 or 4 music genres as derived classes
 *
 * A MusicGenre class will have a protected member variable that holds the genreName. This is initialised via the
 * MusicGenre constructor (remember what we learnt about derived class constructors passing paramters upto their base classes).
 * The MusicGenre class will have a method that returns the genreName.
 *
 * Each Derived class (except the Class that hasn't had a hit) will have a Method called void getHitRecord() which when
 * called will return the name of an example hit record for that genre. The Base (default) version of getHitRecord()
 * will print("No hits for this genre ")
 *
 * In your program create instances of each of the different Genres and call the getHitRecord() method on each and verify that the
 * output is what you would expect for Dynamic polymorphism
 *
 * Your output on the console should be something like:
 *
 * Pop hit record: ABBA Fernando
 * etc
 * etc
 *
 */
