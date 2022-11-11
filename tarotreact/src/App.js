import './App.css';
import GetCard from "./Components/Card/Card";
import {useState} from "react";

function App() {
  const [cardStyle, setCardStyle] = useState('card-hidden');
  const [predictionStyle, setPredictionStyle] = useState('prediction-hidden');

  const handleClick = () => {
    if(cardStyle === 'card-hidden') {
      setCardStyle('');
      setPredictionStyle('');
      return;
    }
    setPredictionStyle('prediction-hidden');
    setCardStyle('card-hidden');
  }

  const goodOrBad= Math.floor(Math.random() * 10);
  const amount= Math.floor(Math.random() * 100);

  const prediction = goodOrBad > 5 ? `You will be millionaire in ${amount} days` : `You will need ${amount} weeks to fix that bug`;

  return (
    <div className="container">
      <header className="title">
        <div className="title__items">
          <h1>For 300kr I See Your Future</h1>
          <button onClick={handleClick}>Donation</button>
        </div>
      </header>

      <main>
        <div className="cards">
          <div className={cardStyle}>{<GetCard />}</div>
          <div className={cardStyle}>{<GetCard />}</div>
          <div className={cardStyle}>{<GetCard />}</div>
        </div>
      </main>
      <footer>
        <div className={predictionStyle}>
          <h3>Prediction: {prediction}</h3>
        </div>
      </footer>
    </div>
  )
}

export default App;
