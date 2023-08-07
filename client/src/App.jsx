import { useState, useEffect } from 'react'
// import './App.css'

function App() {
  const [count, setCount] = useState(0)
  // const [data, setData] = useState([])

  // useEffect(() => {
  //   const fetchData = async () => {
  //     const data = await fetch("https://localhost:7004/api/Client")
  //     const json = await data.json()

  //     setData(json[0])
  //   }

  //   fetchData().catch(err => console.error(err))
  // }, [])

  return (
    <h1 className='text-4xl text-sky-700 font-extrabold'>Hello world</h1>
  )
}

export default App
