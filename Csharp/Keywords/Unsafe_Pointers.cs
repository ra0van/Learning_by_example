/**
	ref : https://msdn.microsoft.com/en-us/library/chfa2zb8.aspx
	A pointer can be any of these:
		. pre defined data type
		. enum
		. user defined struct that contains fields of unmanaged types only
	What is an unmanaged type?? 
	Unmanaged resources are anything which the garbage collector doesn't know about and anything that runs outside the CLR .For Example:
		. Open files
		. Open network connections
		. SQL Connections, etc. 
	
	Pointer types cannot be inherited from an object.
	A pointer type cannot be converted to an object and vice versa.
	However, we can convert between different pointer types.
	
	
**/
