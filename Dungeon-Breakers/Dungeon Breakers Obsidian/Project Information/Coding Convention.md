*Internal note to team members*

* We'll use [CamelCase](https://en.wikipedia.org/wiki/Camel_case)

* We'll use funtions nested in 'if' statements in so the code may be read as a phrase
	*example*
	
	*instead of:*
	`````
	if( i < 10)
	{
		something happens
	}
	``````
	*we will do:*
	```
	if(isBiggerThanTen)
	{
		something happens
	}
		
	public bool(i)
	{
		return i < 10
	}
	```
	*these 'if' functions will all be in one class*

* We will open brackets below the line of code using them
	*example*
	
	*instead of:*
	```
	public bool(i){
		something happens
	}
	```
	*we will do:*
	```
	public bool(i)
	{
		something happens
	}
	```

* when using 'if' we always use brackets even if there is only one line of code

*To be expanded*
