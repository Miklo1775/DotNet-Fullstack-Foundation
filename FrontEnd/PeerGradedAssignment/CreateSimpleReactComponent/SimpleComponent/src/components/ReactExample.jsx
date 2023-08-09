import React from "react";

const backgroundColor = React.createContext('green');

function BackgroundExample(){
    const color = useContext(backgroundColor);
    return(
        <main style={{
            backgroundColor: color==='green' ? '#00FF00' : '#FFFFFF'
        }}>

        </main>
    )
}

function ChuckNorrisJokes(){
    const [jokes, setJokes] = useState([]);

    useEffect(() => {
        async function fetchJokes() {
            const response = await fetch('https://api.chucknorris.io/jokes/random')
            const data = await response.json();
            setJokes(data);
        }

        fetchJokes()
    }, [])
    return (
        <div>Jokes</div>
    )
}