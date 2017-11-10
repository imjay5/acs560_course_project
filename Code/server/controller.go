/**************************************************************
 * controller.go
 *
 * Implements functions for receiving data from C# client
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File

 **************************************************************/

package main

import (
	"encoding/json"
	// "fmt"
	//"net/http"
)

type Controller struct {
}

func (controller *Controller) process_data(msg *json.Decoder, handler string) string {
	var response string 
	switch handler {
	    case "register": 
	    obj := UserDetails{}
	    response = obj.register(msg)
	    
	    case "login":
	    obj := LoginDetails{}
	    response = obj.login(msg)    
	}
	//fmt.Println("******* ", test.User)
	//str := `{"page": 1, "fruits": ["apple", "peach"]}`
	//fmt.Fprintf(w, str)
	return response
}
