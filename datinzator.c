//##########Datingzator################

#include <stdio.h>
#include <stdbool.h>

bool she_said(int said){
	bool me = false;
	switch(said){

	case 1:
		return true;
	case 2:
		return false;
	case 20130610:
		return (!me);
	default:
		luser();
		she_said(question());
	}
}

int question(){
	
	int value, end;
	char buf[BUFSIZ];
	fflush(stdout);
	
	while (fgets(buf, sizeof buf, stdin) == NULL ||
	sscanf(buf, "%d%n", &value, &end) != 1 ||
	!isspace(buf[end]))
	{
		fflush(stdout);
	return value;
	}
	return value;
}

void luser(){
	printf("Only 1 and 2 are valid values, are you dumb? Try again:\n");
}


int main(){
	printf ("Dating? 1 for Yes and 2 for No\n");

	if(she_said(question())){
		printf("\\,,/ - Have fun!\n");
	}else{
		printf(":(\n");
	}
}
