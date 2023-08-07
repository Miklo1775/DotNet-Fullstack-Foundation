const bigHead = document.querySelector(".big-head");
bigHead.addEventListener("click", (e) => {
  bigHead.textContent = "Me bigger head";
});
let counter = 0;
let storedInput;

const form = document.querySelector(".form");
const input = document.querySelector(".input");
const submitBtn = document.querySelector(".sub-btn");

submitBtn.addEventListener("click", (e) => {
  e.preventDefault();
  storedInput = input.value;
  showInput(storedInput);
});

const showInput = (variable) => {
  counter++;
  console.log(variable + counter);
};
