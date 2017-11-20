package main

import (
	"encoding/json"
	"fmt"
	"log"
)

type ExamDetails struct {
	ExamID   string `json:"exam_id"`
	ExamName string `json:"exam_title"`
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

	query := "select exam_id,exam_title from exams"
	parameters := []string{}
	flag, rows := op.get_data(query, parameters)

	query1 := "select count(*) from exams"
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

		err := rows.Scan(&exam_id, &exam_title)
		if err != nil {
			log.Fatal(err)
		}
		log.Println("select result ", exam_id, exam_title, flag)
		if i < count {

			// log.Println(i)
			response += fmt.Sprintf("%s%d%s%s%s", `{"exam_id": `, exam_id, `,"exam_title" : "`, exam_title, `"}, `)
		} else {
			response += fmt.Sprintf("%s%d%s%s%s", `{"exam_id": `, exam_id, `,"exam_title" : "`, exam_title, `"}]`)
		}
		i++
	}

	// response := fmt.Sprintf("%s%d%s%s%s", `{"msg": "success", "exam_id": `, exam_id, `,"exam_title" : `, exam_title, `}`)
	return response
}
