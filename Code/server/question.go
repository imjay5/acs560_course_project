/**************************************************************
 * question.go
 *
 * Implements functions for adding questions to exams
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File

 **************************************************************/

package main

import (
	//"database/sql"
	"encoding/json"
	"fmt"
	_ "github.com/go-sql-driver/mysql"
)

type Question struct {
	ExamId           int    `json:"exam_id"`
	Question         string `json:"question"`
	OptionA          string `json:"option_a"`
	OptionB          string `json:"option_b"`
	OptionC          string `json:"option_c"`
	OptionD          string `json:"option_d"`
	Answer           string `json:"answer"`
	Difficulty_Level string `json:"difficulty_level"`
}

func (question Question) add_question(msg *json.Decoder) string {
	var quesObj Question
	op := Database_Operations{}
	msg.Decode(&quesObj)
	query := "insert into questions values(NULL,?,?,?,?,?,?,?,?)"
	parameters := []interface{}{quesObj.ExamId, quesObj.Question, quesObj.OptionA, quesObj.OptionB, quesObj.OptionC, quesObj.OptionD,
		quesObj.Answer, quesObj.Difficulty_Level}
	fmt.Println("exam id ", quesObj.ExamId)
	flag, result := op.insert_data(query, parameters)
	var id int64
	if flag == true {
		id, _ = result.LastInsertId()
	}
	response := fmt.Sprintf("%s%d%s", `{"msg": "success", "question_id": `, id, `}`)
	return response
}
