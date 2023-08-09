const addButton = document.getElementById("add-btn");

const addImage = () => {
  let inputValue = document.getElementsByTagName("input")[0].value;
  console.log(inputValue);

  const image = document.createElement("img");
  image.src = inputValue;
  image.classList.add("gallery-image");
  const kittenContainer = document.querySelector(".cat-container");
  kittenContainer.insertAdjacentElement("afterbegin", image);
  inputValue = null;
};

addButton.addEventListener("click", addImage);
