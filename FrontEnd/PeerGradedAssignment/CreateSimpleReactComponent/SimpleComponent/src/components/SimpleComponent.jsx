import classes from "./SimpleComponent.module.css";

i;

const SimpleComponent = () => {
  return (
    <div>
      <form className={classes.simpleForm}>
        <div className={classes.inputContainer}>
          <label>Enter Your name: </label>
          <input type="text" name="name" />
        </div>
        <div className={classes.inputContainer}>
          <label>Enter Your Favorite Food: </label>
          <input type="text" name="name" />
        </div>
        <div className={classes.inputContainer}>
          <label>Enter Your Favorite Animal: </label>
          <input type="text" name="name" />
        </div>
        <div className={classes}>
          <label>Enter Your Show: </label>
          <input type="text" name="name" />
        </div>
        <button type="submit">Submit Response</button>
      </form>
    </div>
  );
};

export default SimpleComponent;
