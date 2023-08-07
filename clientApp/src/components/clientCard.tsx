import img from '../assets/mountain.jpg'

type cardProps = {
  name: string,
  email: string
}

function ClientCard(props: cardProps) {
  return (
    <div className='max-w-fit rounded-xl overflow-hidden shadow-lg pb-5'>
      <div className='max-w-full w-52 max-h-56 overflow-hidden mb-3'>
        <img className='object-cover object-center h-full' src={img} alt="" />
      </div>
      <div className="px-3">
        <h1 className='text-xl font-bold'>{ props.name }</h1>
        <h3>{ props.email }</h3>
      </div>
    </div>
  )
}

export default ClientCard