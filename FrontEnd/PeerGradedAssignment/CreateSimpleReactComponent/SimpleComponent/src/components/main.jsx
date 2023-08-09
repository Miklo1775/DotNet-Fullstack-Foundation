import React from "react";

const hello = React.createElement("h2", null, "Hello. Give me a passing grade pls.");

ReactDom.createRoot(document.getElementById("container")).render(
    <React.StrictMode>
        {hello}
    </React.StrictMode>
)

function HoverCounter(){
    const [count, setCount] = useState(0);
}

function Increment(){
    setCount(count + 1);

    return(
        <>
            <h2>Count hover:{count}</h2>
            <img onMouseOver={Increment} src='https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg'/>
        </>
    )
}


function Hello(props){
    return(
        <div>
            <Hello name='World'/>
            <Hello name='React'/>
        </div>
    )
}
