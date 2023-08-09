import { useState } from "react";
import classes from "./SimpleComponent.module.css";

const SimpleComponent = ({ setResults }) => {
  const [inputs, setInputs] = useState({
    name: "",
    food: "",
    animal: "",
    show: "",
  });

  const handleInputs = (e) => {
    switch (e.target.id) {
      case "name":
        setInputs({ ...inputs, name: e.target.value });
        break;
      case "food":
        setInputs({ ...inputs, food: e.target.value });
        break;
      case "animal":
        setInputs({ ...inputs, animal: e.target.value });
        break;
      case "show":
        setInputs({ ...inputs, show: e.target.value });
        break;
    }
  };

  const submitResults = (e) => {
    e.preventDefault();
    if (inputs.name !== "" && inputs.food !== "" && inputs.animal !== "" && inputs.show !== "") {
      setResults(inputs);
    }
  };

  return (
    <div>
      <form className={classes.simpleForm} onSubmit={submitResults}>
        <div className={classes.inputContainer}>
          <label>Enter Your name: </label>
          <input type="text" id="name" onChange={handleInputs} required />
        </div>
        <div className={classes.inputContainer}>
          <label>Enter Your Favorite Food: </label>
          <input type="text" id="food" onChange={handleInputs} required />
        </div>
        <div className={classes.inputContainer}>
          <label>Enter Your Favorite Animal: </label>
          <input type="text" id="animal" onChange={handleInputs} required />
        </div>
        <div className={classes.inputContainer}>
          <label>Enter Your Show: </label>
          <input type="text" id="show" onChange={handleInputs} required />
        </div>
        <button type="submit">Submit Response</button>
      </form>
    </div>
  );
};

export default SimpleComponent;
