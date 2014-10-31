UniEnrolSystem
==============

QUESTION 1	Total	Mark
Unit class		
_Code and _Name attributes with matching properties	1	1
Constructor with code and name parameters initialises attributes	1	1
ToString returns appropriately formatted string	1	1

Result class		
_Mark attribute with matching property	1	1
Constructor with mark parameter initialises attribute	1	1
Read-only Grade property returns correctly determines grade from mark	2	2
ToString returns appropriately formatted string	2	2

Enrolment class		
_Unit reference with matching read-only property	2	2
_Result reference with matching read/write properties	2	2
Constructor with unit and result parameters initialises attributes	2	2
ToString returns appropriately formatted string	2	2

Student class		
_ID, _FamilyName, and _GivenName attributes with matching properties	3	3
Constructor with id, familyName, and givenName parameters initialises attributes	3	3
ToString returns appropriately formatted string	2	2
MAX_UNITS is a constant integer with value four	2	2
_EnrolledUnits is an array of size four	2	2
_EnrolledUnits uses MAX_UNITS	1	1
_EnrolledMax is initialised to -1	2	2
Enrol method checks _EnrolledMax against MAX_UNITS/_EnrolledUnits.Length	2	2
Enrol method stores Enrolment object in next available slot	1	1
Enrol method increments _EnrolledMax	1	1
Indexer property uses loop to find Enrolment object	1	1
Indexer property only checks _EnrolledUnits array slots up to _EnrolledMax	1	1
Indexer property compares unit code parameter with _EnrolledUnits[i].Unit.Code	1	1
Indexer property returns Enrolment object or null on success/fail	1	1

QUESTION 2		
Reasonable discussion of overall development of the program	2	2
Reasonable discussion of development of Unit, Result, and Enrolment classes	2	2
Reasonable discussion of development of the Student class	2	2
Reasonable discussion of use of/development of the _EnrolledUnits array	2	2
Reasonable discussion of application of object-oriented concepts	2	2
Total Mark	50	50

