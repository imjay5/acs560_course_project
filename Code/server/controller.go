/**************************************************************
 * controller.go
 *
 * Implements handler for different request types from C# client
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File
 *   Kanika			 Addition				 Added method process_data()
 *	 Jaya			 Addition				 Added cases for login(), register()
 *	 Jaya			 Addition				 Added cases for selectExam(), takeExam()
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

	case "addExam":
		obj := Exam{}
		response = obj.create_exam(msg)

	case "addQuestion":
		obj := Question{}
		response = obj.add_question(msg)

	case "selectExam":
		obj := ExamDetails{}
		response = obj.selectExam(msg)

	case "takeExam":
		obj := ExamDetails{}
		response = obj.takeExam(msg)

	case "takenExams":
		obj := ExamDetails{}
		response = obj.takenExams(msg)

	case "updateGrades":
		obj := ExamDetails{}
		response = obj.updateGrades(msg)

	case "getExam":
		obj := Exam{}
		response = obj.get_exam(msg)

	case "updateExam":
		obj := Exam{}
		response = obj.update_exam(msg)
	case "getQuestion":
		obj := Question{}
		response = obj.get_next_question(msg)
	case "deleteQuestion":
		obj := Question{}
		response = obj.delete_question(msg)
	case "updateQuestion":
		obj := Question{}
		response = obj.update_question(msg)
	case "getAllQuestions":
		obj := Question{}
		response = obj.get_all_questions(msg)
	case "updateExamStatus":
		obj := Exam{}
		response = obj.update_exam_status(msg)
	case "getAllExams":
		obj := Exam{}
		response = obj.get_all_exams(msg)
	case "getReport":
		obj := Exam{}
		response = obj.get_report(msg)
	}
	return response
}
