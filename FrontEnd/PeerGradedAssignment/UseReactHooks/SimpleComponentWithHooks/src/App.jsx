import "./App.css";
import ShowResults from "./components/ShowResults";
import SimpleComponent from "./components/SimpleComponent";

import { useState } from "react";

function App() {
  const [results, setResults] = useState({});

  return (
    <>
      <ShowResults results={results} />
      <SimpleComponent setResults={setResults} results={results} />
    </>
  );
}

export default App;
