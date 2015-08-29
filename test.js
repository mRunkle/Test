var survey = {
    Complete1: {  //individual users survey, (Gary, Pete, Ted)
        id : "111",  //machine _id of Gary's survey
        template_id : "1",  //template from which the survey was generated
        answers : {Q1:"blah!", Q2:"Blah!!", Q3:"BLAH!!!"},  //collection of answers from Gary's survey
    }
}

console.log(survey);

/*
var dict = {
  "1" : false,
  "2" : true,
  "3" : false
};
*/

/*
// lookup:
var second = dict["2"];
console.log(second);

// update:
dict["2"] = false;
console.log(dict);

// add:
dict["4"] = true;
console.log(dict);

// delete:
delete dict["2"];
console.log(dict);
*/


var userSet = survey["Complete1"];
var userSet_machineID = userSet["id"];
var userSet_templateID = userSet["template_id"];
var userSet_answerSet = userSet["answers"];

var Q1_answer = userSet_answerSet["Q1"];
var Q2_answer = userSet_answerSet["Q2"];
var Q3_answer = userSet_answerSet["Q3"];

/*
console.log(survey);
console.log(userSet);
console.log(userSet_machineID);
console.log(userSet_templateID);
console.log(userSet_answerSet);

console.log(Q1_answer);
console.log(Q2_answer);
console.log(Q3_answer);
*/

 


$("button").click(function() {
	survey["Complete1"]["answers"] = {Q1: 1};

	console.log(survey);
});