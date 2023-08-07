import { BrowserRouter, Routes, Route } from 'react-router-dom'

import ClientList from "./pages/clientList"
import ClientDetails from "./pages/clientDetails"

function App() {
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
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<ClientList />} />
        <Route path='/details' element={<ClientDetails />} />
      </Routes>
    </BrowserRouter>
  )
}

export default App
