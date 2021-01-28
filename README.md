Console Application<br/>
Exercise: Strings and Text Processing
# StringExplosion
Explosions are marked with '__>__'. Immediately after the mark, there will be an __integer__, which signifies the __strength__ of the explosion.<br/>
You should __remove x characters__ (where __x__ is the __strength__ of the explosion), __starting after__ the punch character ('__>__').<br/>
If you find __another__ explosion mark ('__>__') while you’re deleting characters, you should __add__ the __strength__ to your __previous explosion__.<br/>
When all characters are processed, __print__ the string __without__ the __deleted__ characters. <br/>
You should __not__ delete the __explosion__ character – '__>__', but you should __delete__ the __integers__, which represent the __strength__. 
## Input
You will receive __single line__ with the string.
## Output
Print what is left from the string after explosions.
## Constraints
* You will __always__ receive a __strength__ for the punches
* The path will consist only of letters from the __Latin alphabet__, __integers__ and the char '__>__'
* The __strength__ of the punches will be in the interval __[0…9]__
## Examples
Input|Output|Comments
-----|------|--------
abv>1>1>2>2asdasd|abv>>>>dasd|__1st__ explosion is at index 3 and it is with strength of 1. We delete only the digit after the explosion character. The string will look like this: abv>>1>2>2asdasd<br/> __2nd__ explosion is with strength one and the string transforms to this: abv>>>2>2asdasd<br/> __3rd__ explosion is now with strength of 2. We delete the digit and we find another explosion. At this point the string looks like this: abv>>>>2asdasd.<br/> __4th__ explosion is with strength 2. We have 1 strength left from the previous explosion, we add the strength of the current explosion to what is left and that adds up to a total strength of 3. We delete the next three characters and we receive the string abv>>>>dasd We do not have any more explosions and we print the result: abv>>>>dasd
peter>2sis>1a>2akarate>4hexmaster|peter>is>a>karate>master|
