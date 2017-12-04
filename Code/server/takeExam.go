/**************************************************************
 * takeExam.go
 *
 * Implements functions for Take Exam module
 *
 * 	                Version History
 *--------------------------------------------------------------
 *   Author          Type of change          Description
 *   Jaya			 Addition				 Created File
 *   Jaya			 Addition				 Added methods takeExam()
 *   Jaya			 Addition				 Added methods selectExam()
 *   Jaya			 Addition				 Added methods takenExams(), updateGrades()
 **************************************************************/

package main

import (
	"encoding/json"
	"fmt"
	"log"
)

type ExamDetails struct {
	ExamID   int    `json:"exam_id"`
	ExamName string `json:"exam_title"`
	UserID   int    `json:"user_id"`
	Grade    string `json:"grade"`
}

func (question1 ExamDetails) takeExam(msg *json.Decoder) string {
	op := Database_Operations{}
	var questionDetails ExamDetails
	var question_id int
	var question string
	var option_a string
	var option_b string
	var option_c string
	var option_d string
	var answer string
	var difficulty_level string
	var flag bool
	var response string
	var count int

	json := msg.Decode(&questionDetails)
	fmt.Println("Success", json)

	query := "select question_id,question,option_a,option_b,option_c,option_d,answer,difficulty_level from questions where exam_id = ?"
	parameters := []interface{}{questionDetails.ExamID}
	flag, rows := op.get_data(query, parameters)

	count_query := "select count(*) from questions where exam_id = ?"
	params := []interface{}{questionDetails.ExamID}
	_, rows1 := op.get_data(count_query, params)

	for rows1.Next() {
		err := rows1.Scan(&count)
		if err != nil {
			log.Fatal(err)
		}
	}
	response = "["
	i := 1
	for rows.Next() {

		err := rows.Scan(&question_id, &question, &option_a, &option_b, &option_c, &option_d, &answer, &difficulty_level)
		if err != nil {
			log.Fatal(err)
		}
		log.Println("select result ", question_id, question, option_a, option_b, option_c, option_d, answer, difficulty_level, flag)
		if i < count {
			response += fmt.Sprintf("%s%d%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s", `{"question_id": `, question_id, `,"question" : "`, question, `","option_a" : "`, option_a, `","option_b" : "`, option_b, `","option_c" : "`, option_c, `","option_d" : "`, option_d, `","answer" : "`, answer, `","difficulty_level" : "`, difficulty_level, `"}, `)
		} else {
			response += fmt.Sprintf("%s%d%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s", `{"question_id": `, question_id, `,"question" : "`, question, `","option_a" : "`, option_a, `","option_b" : "`, option_b, `","option_c" : "`, option_c, `","option_d" : "`, option_d, `","answer" : "`, answer, `","difficulty_level" : "`, difficulty_level, `"}] `)
		}
		i++
	}
	return response
}

func (exam ExamDetails) selectExam(msg *json.Decoder) string {
	op := Database_Operations{}
	var examDetails ExamDetails
	var exam_id int
	var exam_title string
	var flag bool
	var response string
	var count int

	json := msg.Decode(&examDetails)
	fmt.Println("Success", json)

	query := "SELECT e.exam_id, e.exam_title FROM exams e where not exists( select null from user_grades ug where e.exam_id = ug.exam_id and ug.user_id = ?) and e.status = 'Active'"
	parameters := []interface{}{examDetails.UserID}
	flag, rows := op.get_data(query, parameters)

	count_query := "SELECT count(*) FROM exams e where not exists( select null from user_grades ug where e.exam_id = ug.exam_id and ug.user_id = ?) and e.status = 'Active'"
	params := []interface{}{examDetails.UserID}
	_, rows1 := op.get_data(count_query, params)

	for rows1.Next() {
		err := rows1.Scan(&count)
		if err != nil {
			log.Fatal(err)
		}
	}
	response = "["
	i := 1
	for rows.Next() {

		err := rows.Scan(&exam_id, &exam_title)
		if err != nil {
			log.Fatal(err)
		}
		log.Println("select result ", exam_id, exam_title, flag)
		if i < count {
			response += fmt.Sprintf("%s%d%s%s%s", `{"exam_id": `, exam_id, `,"exam_title" : "`, exam_title, `"}, `)
		} else {
			response += fmt.Sprintf("%s%d%s%s%s", `{"exam_id": `, exam_id, `,"exam_title" : "`, exam_title, `"}]`)
		}
		i++
	}
	return response
}

func (exam ExamDetails) takenExams(msg *json.Decoder) string {
	op := Database_Operations{}
	var takenExams ExamDetails
	var exam_id int
	var exam_title string
	var grade string
	var flag bool
	var response string
	var count int

	json := msg.Decode(&takenExams)
	fmt.Println("Success", json)

	query := "SELECT e.exam_id, e.exam_title, ug.grade FROM exams e LEFT JOIN user_grades ug ON e.exam_id = ug.exam_id WHERE ug.user_id = ?"
	parameters := []interface{}{takenExams.UserID}
	flag, rows := op.get_data(query, parameters)

	count_query := "SELECT count(*) FROM exams e LEFT JOIN user_grades ug ON e.exam_id = ug.exam_id WHERE ug.user_id = ?"
	params := []interface{}{takenExams.UserID}
	_, rows1 := op.get_data(count_query, params)

	for rows1.Next() {
		err := rows1.Scan(&count)
		if err != nil {
			log.Fatal(err)
		}
	}
	response = "["
	i := 1
	for rows.Next() {

		err := rows.Scan(&exam_id, &exam_title, &grade)
		if err != nil {
			log.Fatal(err)
		}
		log.Println("select result ", exam_id, exam_title, grade, flag)
		if i < count {

			response += fmt.Sprintf("%s%d%s%s%s%s%s", `{"exam_id": `, exam_id, `,"exam_title" : "`, exam_title, `","grade" : "`, grade, `"}, `)
		} else {
			response += fmt.Sprintf("%s%d%s%s%s%s%s", `{"exam_id": `, exam_id, `,"exam_title" : "`, exam_title, `","grade" : "`, grade, `"}]`)
		}
		i++
	}
	return response
}

func (grades ExamDetails) updateGrades(msg *json.Decoder) string {
	var gradeDetails ExamDetails
	var op Database_Operations
	var response string
	var flag bool

	json := msg.Decode(&gradeDetails)
	fmt.Println("Success", json)

	query := "insert into user_grades values(?,?,?)"
	parameters := []interface{}{gradeDetails.UserID, gradeDetails.ExamID, gradeDetails.Grade}
	flag, result := op.insert_data(query, parameters)

	log.Println("flag", flag)
	log.Println(result)

	response = `{"msg": "success"}`

	return response
}
