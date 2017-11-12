/**************************************************************
 * controller.go
 *
 * Implements handler for different request types from C# client
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File

 **************************************************************/

package main

import (
	"encoding/json"
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
		obj := UserDetails{}
		response = obj.login(msg)

	case "create":
		obj := Exam{}
		response = obj.create_exam(msg)

	case "addQ":
		obj := Question{}
		response = obj.add_question(msg)

	}
	return response
}
