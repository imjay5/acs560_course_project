package main

import (
	"encoding/json"
	"fmt"
	"log"
)

type QuestionDetails struct {
	ExamID string `json:"exam_id"`
}

func (question1 QuestionDetails) takeExam(msg *json.Decoder) string {
	op := Database_Operations{}
	var questionDetails QuestionDetails
	// var exam_id int
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

	query := "select question_id,question,option_a,option_b,option_c,option_d,answer,difficulty_level from questions where exam_id = 19"
	parameters := []string{}
	flag, rows := op.get_data(query, parameters)

	query1 := "select count(*) from questions where exam_id = 19"
	parameters1 := []string{}
	_, rows1 := op.get_data(query1, parameters1)

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

			// log.Println(i)
			response += fmt.Sprintf("%s%d%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s", `{"question_id": `, question_id, `,"question" : "`, question, `","option_a" : "`, option_a, `","option_b" : "`, option_b, `","option_c" : "`, option_c, `","option_d" : "`, option_d, `","answer" : "`, answer, `","difficulty_level" : "`, difficulty_level, `"}, `)
		} else {
			response += fmt.Sprintf("%s%d%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s", `{"question_id": `, question_id, `,"question" : "`, question, `","option_a" : "`, option_a, `","option_b" : "`, option_b, `","option_c" : "`, option_c, `","option_d" : "`, option_d, `","answer" : "`, answer, `","difficulty_level" : "`, difficulty_level, `"}] `)
		}
		i++
	}

	// response := fmt.Sprintf("%s%d%s%s%s", `{"msg": "success", "exam_id": `, exam_id, `,"exam_title" : `, exam_title, `}`)
	return response
}
