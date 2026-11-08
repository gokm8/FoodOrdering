import { useState, useEffect } from 'react'
import './App.css'



type MenuItem = {
  id: number
  name: string
  description: string | null
  price: number
}

function App() {
  const [data, setData] = useState<MenuItem[]>([])

  useEffect(() => {
    fetch('/api/menu')
      .then(res => {
        if (!res.ok) {
          throw new Error('Kunne ikke hente menuen')
        }

        return res.json()
      })
      .then((items: MenuItem[]) => setData(items))
      .catch(error => console.error(error))
  }, [])

  return (
    <>
      <table>
      
      <thead>
        <tr>
            <th>Navn</th>
            <th>Pris</th>
            <th>ID</th>
        </tr>
      </thead>

      <tbody>

        {data.map(item => (

        <tr key={item.id}>
            <td>{item.name}</td>
            <td>{item.price}</td>
            <td>{item.id}</td>    
        </tr>

        ))}

      </tbody>

      </table>
    </>
  )
}

export default App
