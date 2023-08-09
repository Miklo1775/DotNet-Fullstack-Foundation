import { useEffect, useState } from "react";

const ShowResults = ({ results }) => {
  const [joke, setJoke] = useState("");

  useEffect(() => {
    const fetchJoke = async () => {
      try {
        const response = await fetch("https://catfact.ninja/fact");
        const data = await response.json();
        setJoke(data.fact);
      } catch (err) {
        setJoke(err.message);
      }
    };
    fetchJoke();
  }, [results]);
  return (
    <div>
      {results.name && results.food && results.animal && results.show && (
        <>
          <p>Hello! Your name is {results.name}!</p>
          <p>Your favorite food is {results.food}!</p>
          <p>Your favorite animal are {results.animal}s</p>
          <p>Your favorite show is {results.show}</p>
          <p>It was nice knowing you! :D</p>
        </>
      )}
      <p>
        Random cat fact with useEffect fetching from API: <strong>{joke}</strong>
      </p>
    </div>
  );
};

export default ShowResults;
