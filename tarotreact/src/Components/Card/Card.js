import {useEffect, useState} from "react";
import './Card.css'

const GetCard = () => {
  const [card, setCard] = useState([]);

  useEffect(() => {
    fetch('https://localhost:7170/Tarot/')
      .then(response => response.json())
      .then(json => {
        setCard(json)
      })
  }, []);

  const random= Math.floor(Math.random() * 10);
  const cardFlip = random < 5 ? 'card__image' : 'card__image-rotated'

console.log(card);
console.log(typeof card);
  return (
    <div className="card">
      <h2 className="card__name item">{card.number} {card.name}</h2>
      <img className={cardFlip} src={card.image} alt={card.name}/>
      <a className="card__link item" href={card.link}>More info</a>
    </div>

  )}

export default GetCard
